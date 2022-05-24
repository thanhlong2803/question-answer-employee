import React, {  useEffect, useState } from "react";
import { userService } from "../../_services/users/user.service";
import { Link } from "react-router-dom";
import "../users/user.less"

function List({ match }) {
  const [users, setUsers] = useState(null);  

  useEffect(() => {
    const fetchUserList = async () => {
      try {
        const response = await userService.getAll();
        setUsers(response);
      } catch {}
    };
    fetchUserList();
  }, []);

  return (
    <div className="container">
      <div className="row mt-12">
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
                <th>Fullname</th>
                <th>Status Test</th>
              </tr>
            </thead>
            <tbody>
                    {users && users.map(user =>
                        <tr key={user.userId}>
                            <td>{user.firstName}</td>
                            <td> {user.lastName}</td>
                            <td>{user.firstName} {user.lastName}</td>
                            <td style={{ whiteSpace: 'nowrap' }}>
                                {/* <Link to={`${path}/edit/${user.userId}`} className="btn btn-sm btn-primary mr-1">Edit</Link> */}
                                <button  className="btn btn-sm btn-info btn-info-user" disabled={user.isDeleting}>
                                    {user.isDeleting 
                                        ? <span className="spinner-border spinner-border-sm"></span>
                                        : <span>Create test</span>
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

export { List };
