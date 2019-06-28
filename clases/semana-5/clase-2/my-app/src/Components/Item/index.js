import React from 'react';
import Button from '../Button';

const Item = ({ handleDelete, item }) => {
    const deleteItem = () => {
        handleDelete(item.id)
    }
    <div>
        <h2 class="fa-1x">{item.text}</h2>
        <Button handleOnClick={deleteItem} text="Delete" />
        <br />
    </div>
};

export default Item;