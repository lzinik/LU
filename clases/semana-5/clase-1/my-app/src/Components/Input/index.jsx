import React from 'react'

const Input = ({value, handleOnChange, handleEnterPressed}) => (
    <input className="form-control" onChange={handleOnChange} value={value} onKeyDown={handleEnterPressed}/>
)

export default Input;
