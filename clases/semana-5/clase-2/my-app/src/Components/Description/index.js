import React from 'react';

const Description = ({ text }) => {
    return (
        <textarea className="form-control">
            {text}
        </textarea>
    );
};

export default Description;