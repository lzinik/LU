import React, { useState } from 'react';
import ListItem from '../../Components/ListItem'
import Form from '../../Components/Form'
import Card from '../Card'


const App = () => {
  const [title, setTitle] = useState("");

  return(
    <div className="container-fluid">
      <div className="row">
        <div className="col-9 bg-info">
          {list.map(element => (
            <div>
              <Item item={element} handleDelete={deleteItem} />
            </div>
          ))}
        </div>
        <div className="col-3">
          <div className="row" />
        </div>
      </div>
    </div>
  );
}

export default App;
