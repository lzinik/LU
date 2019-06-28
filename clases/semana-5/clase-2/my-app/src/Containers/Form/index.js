import React, {useState} from 'react';
import Title from '../../Components/Title';
import Description from '../../Components/Description';
import Button from '../../Components/Button';

const Form = () => {
    
    const [text, setText] = useState('');
    const [id, setId] = useState(0);
    const [list, setList] = useState([]);

    const createItem = () => {
        const element = {
            id,
            text
        };
        setList([...list, element]);
        setText('');
        setId(id + 1);
    }

    return (
        <div class="col-md-3 card m-3">
            <Title handleOnChange={setText} value={text} />
            <Description />
            <Button handleOnClick={createItem} text="Agregar Item" />
        </div>
    );
};

export default Form;