import React, { useState } from 'react';

import Button from '../../Components/Button';
import ErrorMessage from '../../Components/ErrorMessage';
import Input from '../../Components/Input';
import ItemList from '../../Components/ItemList';
import Title from '../../Components/Title';


const App = () => {
      
  const [text, setText] = useState("Título inicial");
  const [newText, setNewText] = useState("");
  const [showErrorMessage, setShowErrorMessage] = useState(false);
  const [itemList, setItemList] = useState([]);

  const handleTitleUpdate = () => {
    if (newText.trim().length > 0) {
      setItemList([...itemList, newText]);
      setText(newText);
      setNewText("");
    } else {
      setShowErrorMessage(true);
    }
  };

  const handleEnterPressed = e => {
    if (e.keyCode === 13){
      handleTitleUpdate();
    }
  }

  const handleNewText = e => {
    setNewText(e.target.value);
    setShowErrorMessage(false);
  }

  return (
    <div className="container-fluid">
        <Title text={text}/>
        <div className="row">
          <div className="col-6">
            <Input value={newText} handleOnChange={handleNewText} handleEnterPressed={handleEnterPressed}/>
            {showErrorMessage && <ErrorMessage text="No se puede agregar un item vacío" />}
          </div>
          <div className="col-6">
            <Button text="Actualizar Título" handleOnClick={handleTitleUpdate}/>
          </div>
        </div>
        <div className="wrapper pt-3">
          {itemList.length > 0 && <h4>Historial de Títulos</h4> }
          <ItemList itemList={itemList} />
        </div>
    </div>
  );
}

export default App;
