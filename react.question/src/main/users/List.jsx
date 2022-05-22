import React, { Component, useEffect, useState } from "react";
import { userService } from "../../_services/users/user.service";
import { Link } from "react-router-dom";

// class UserPage extends Component {
//     constructor(props) {
//         super(props);
//         const [users, setUsers] = useState(null);

//     }

//     componentDidMount() {
//        const fetchUserList = async() => {
//            try{
//             const response = await userService.getAll();
//             this.state = response;
//            }
//            catch{
//            }
//        }

//        fetchUserList();
//     }

//     render() {
//         const { users } = this.state;
//         return (
//             <div className="container">
//             	<div class="row mt-5">
//                 <div class="col-md-12">
//                     <div class="title-header text-center">
//                         <h4>Users For Question</h4>
//                     </div>
//                 </div>
//             </div>
//             <div className="row">
//                 <div className="span5">
//                     <table className="table table-striped table-bordered">
//                           <thead>
//                           <tr>
//                               <th>Fristname</th>
//                               <th>Lastname</th>
//                               <th>Status</th>
//                           </tr>
//                       </thead>
//                       <tbody>
//                         <tr>
//                             <td>Donna R. Folse</td>
//                             <td>2012/05/06</td>
//                             <td><span className="label label-success">Active</span>
//                             </td>
//                         </tr>
//                       </tbody>
//                     </table>
//                     </div>
//             </div>
//         </div>
//         );
//     }
// }

function UserList({ match }) {
  const { path } = match;
  const [users, setUsers] = useState(null);

  function getAll() {
    const fetchUserList = async () => {
      try {
        const response = await userService.getAll();
        setUsers(response);
      } catch {}
    };
  }

  useEffect(() => {
    this.getAll();
  }, []);

  return (
    <div className="container">
      <div class="row mt-5">
        <div class="col-md-12">
          <div class="title-header text-center">
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
                <th>Fullname</th>
                <th>Status</th>
              </tr>
            </thead>
            <tbody>
                    {users && users.map(user =>
                        <tr key={user.userId}>
                            <td>{user.firstName}</td>
                            <td> {user.lastName}</td>
                            <td>{user.firstName} {user.lastName}</td>
                            <td style={{ whiteSpace: 'nowrap' }}>
                                <Link to={`${path}/edit/${user.userId}`} className="btn btn-sm btn-primary mr-1">Edit</Link>
                                <button  className="btn btn-sm btn-danger btn-delete-user" disabled={user.isDeleting}>
                                    {user.isDeleting 
                                        ? <span className="spinner-border spinner-border-sm"></span>
                                        : <span>Delete</span>
                                    }
                                </button>
                            </td>
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

export { UserList };
