import React from 'react';

function AddOrUpdate({ match }) {
  
  return (
    <div className="container">
      <div className="row mt-12">
        <div className="col-md-12">
          <div className="title-header text-center">
            <h4>Design Add and Edit User</h4>
          </div>
        </div>
      </div>
      <div className="row">
        <div className="span12">
          <div className="col-md-12">
              <div className="md-form">
                  <label htmlFor="name" className="">Firstname</label>
                  <input type="text" id="name" name="name" className="form-control" />               
              </div>
              <div className="md-form">
                  <label htmlFor="name" className="">Lastname</label>
                  <input type="text" id="name" name="name" className="form-control" />               
              </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export { AddOrUpdate };
