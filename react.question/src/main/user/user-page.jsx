import React, { Component,  useState } from "react";
import { userService } from "../../_services/users/user.service"
import './user-page.css'

class UserPage extends Component {
    constructor(props) {
        super(props);
        this.state = {users: null};
    }

    componentDidMount() {
       const fetchUserList = async() => {
           try{
            const response = await userService.getAll();    
            this.setState({ users: response })
           }
           catch{
           }
       }

       fetchUserList();
    }

    render() {
         const { users } = this.state;
        return (
            <div className="container">
            	<div className="row mt-5">
                <div className="col-md-12">
                    <div className="title-header text-center">
                        <h4>Users For Question</h4>
                    </div>
                </div>
            </div>
            <div className="row">
                <div className="span5">
                    <table className="table table-striped table-bordered">
                          <thead>
                          <tr>
                              <th>Fristname</th>
                              <th>Lastname</th>
                              <th>Status</th>
                          </tr>
                      </thead>
                      <tbody>
                        
                      {users && users.map(user =>
                        <tr key={user.userId}>
                            <td>{user.firstname}</td>
                            <td> {user.lastName}</td>
                            <td>{user.firstname} {user.lastName}</td>
                          
                        </tr>
                    )}
                    {!users &&
                        <tr>
                            <td colSpan="4" className="text-center">
                                <div className="spinner-border spinner-border-lg align-center"></div>
                            </td>
                        </tr>
                    }
                    {users && !users.length &&
                        <tr>
                            <td colSpan="4" className="text-center">
                                <div className="p-2">No Users To Display</div>
                            </td>
                        </tr>
                    }
                      </tbody>
                    </table>
                    </div>
            </div>
        </div>
        );
    }
}
export   { UserPage};