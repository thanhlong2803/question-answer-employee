import React, { useState, useEffect } from 'react'
import DetailFields from '../child/child-class-component'

export default function ParentComponent(props) {
    //Set initial Values   
    console.log(props.model);
    const [model, setModel] = useState(props.model);

    useEffect(() => {
        setModel(props.model);
    }, [props.model]);

    //  call API
    const handleSubmit = (event) => {
        //...Here you have model values and you can send it to api
        //callApi(model);
        //fack
    };

    //Set Values from the input to the model when the values changed
    const handleChange = (event) => {
        debugger;

        // get the value of the field
        const value = event?.target?.value;
        console.log(model);

        //set it in the model
        setModel({ ...model, [event.target.name]: value, });
    };

    return (
        <div>
            <DetailFields
                model={model}
                // pass the function to child component
                handleChange={handleChange}
            />

            {/* <input type="submit" value="Submit" onClick={handleSubmit} /> */}
        </div>
    );
}