import React, {useState} from 'react';
import Title from '../../Components/Title';
import Button from '../../Components/Button';
import Description from '../../Components/Description';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faSave, faEdit, faTrash, faTimesCircle } from '@fortawesome/free-solid-svg-icons'

const Card = () => {
    
    const [text, setText] = useState('');
    const [id, setId] = useState(0);
    const [list, setList] = useState([]);

    const addItem = () => {
        const element = {
            id,
            text
        };
        setList([...list, element]);
        setText('');
        setId(id + 1);
    }
    const deleteItem = id => {
        setList(list.filter(e => e.id !== id));
    }


    return (
        <div class="col-md-3 card m-3">
            <Input handleOnChange={setText} value={text} />
            <Button handleOnClick={addItem} text="Agregar Item" />
            <hr />
            {list.map(element =>
                <div>
                    <Item item={element} handleDelete={deleteItem} />
                </div>
            )}
        </div>
    );
};

export default Card;