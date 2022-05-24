import React from 'react';
import { Route, Routes,useLocation } from 'react-router-dom';
import { List } from './List';

function Users({ match }) {   
    const { pathname } = useLocation();   
    return (   
         <Routes>
           <Route exact path="" element={<List />}  />    
           {/* <Route path={`${pathname}/add`} element={AddEdit} />
           <Route path={`${pathname}/edit/:id`} element={AddEdit} /> */}
         </Routes>
    );
}
export { Users };