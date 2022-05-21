import React,{Component} from 'react';
import {UserService} from '../../_services/users/user.service' 
import {axios} from 'axios'

class UserPage extends Component {        
    constructor(props) {
        super(props);
        this.state = {users: null};
    }

    componentDidMount() {
        fetch('https://localhost:7017/User')
        .then(response => response.json())
        .then(data => this.setState({ users: data }))
    }

    render() {
        const { users } = this.state;                
        return (
            <div>
                <h1>Employee</h1>
                <div>                 
                    {users &&
                        <ul>
                            {users.map(user =>
                                <li key={user.userId}>{user.firstname} {user.lastName}</li>
                            )}
                        </ul>
                    }
                </div>
            </div>
        );
    }
}

export { UserPage};