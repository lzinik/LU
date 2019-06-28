import React from 'react'

const ItemList = ({ itemList }) => (
    <ul className="list-group">
        {itemList.map((item, index) =>
            <li className="list-group-item" key={item+index}>{
                item}
            </li>
        )}
    </ul>
)

export default ItemList;
