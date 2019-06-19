import React, {useState} from 'react';
import Title from '../../Components/Title';
import Button from '../../Components/Button';
import Description from '../../Components/Description';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faSave, faEdit, faTrash, faTimesCircle } from '@fortawesome/free-solid-svg-icons'

const Card = () => {
    const [titleText, setTitleText] = useState('Default Title');
    const [description, setDescription] = useState('');
    const [icon1, setIcon1] = useState(faEdit);
    const [icon2, setIcon2] = useState(faTrash);
    const [button1Val, setButton1Val] = useState('Editar');
    const [button2Val, setButton2Val] = useState('Eliminar');

    const handlePosClick = (e) => {
        // if(e.target.value === 'Editar') {
            setIcon1(faSave)
            setButton1Val("Guardar")
        // }
        // } else
        //     setDescription(description);
    }
    const handleNegClick = (e) => {
        if(e.target.value === "Editar") {
            setIcon2(faTimesCircle)
            setButton1Val("Guardar")
        }
    }


    return (
        <div class="col-md-3 card m-3">
            <Title text={titleText} />
            <Description text={description} />
            <div class="btn-group m-2">
                <Button icon={icon1} value={button1Val} classNameButton="btn btn-primary" onClick={handlePosClick} />
                <Button icon={icon2} value={button2Val} classNameButton="btn btn-danger" onClick={handleNegClick} />
            </div>
        </div>
    );
};

export default Card;