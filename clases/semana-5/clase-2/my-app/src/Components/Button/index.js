import React, { Component } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

const Button = ({ icon, value, handleOnClick, classNameButton }) =>  {
    return (
        <div>
            <button className={classNameButton} value={value} onClick={handleOnClick}>
                <FontAwesomeIcon icon={icon} /> 
                {value} 
            </button>
        </div>
    );
}

export default Button;