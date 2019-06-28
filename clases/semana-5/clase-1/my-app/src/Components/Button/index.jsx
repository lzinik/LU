import React from 'react'

const Button = ({ text, handleOnClick }) => {
    return (
        <button className="btn btn-primary" onClick={handleOnClick}>{text}</button>
    );
}

export default Button
