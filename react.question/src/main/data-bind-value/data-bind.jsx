
import React, { useState } from "react";

export default function BindingDataValue(props) {
    const [model, setModel] = useState('');

    const onClick = (e) => {
        console.log(model);
    }
    
    const handleChange = (event) => {
        const value = event?.target?.value;
        setModel({ ...model, [event.target.name]: value });    
    };

    return (
        <div>
            <h1>{model.showInfo}</h1>

            <input id="firstname" type="text" name="firstname" onChange={handleChange} value={model.firstname} />
            <input id="lastname" type="text" name="lastname" onChange={handleChange} value={model.lastname} />
            <br />

            <button onClick={onClick} value="Submit">Submit</button>
        </div>
    );
}