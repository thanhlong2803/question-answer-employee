import React from "react";

export default function DetailFields(props) {

    console.log("child-component: ", props);
    const modelChild = props.model === undefined || props.model === null ? "" : props.model;

    return (
        <div className="stepOne">
            <ul>
                <li>
                    <label>username</label>
                    <input id="username" name="username" type="text" value={modelChild.username || ""} onChange={props.handleChange} />
                </li>
                <li>
                    <label>lastname</label>
                    <input id="lastname" name="lastname" type="text" value={modelChild.lastname || ""} onChange={props.handleChange} />
                </li>
            </ul>
        </div>

    );
};