import React, {Suspense } from "react";
import {  Routes,  Route,  Router} from "react-router-dom";

// import { Nav, Alert } from '@/_components';
// import { Home } from '@/home';

import {Users} from "../main/users/Index";
import { AddOrUpdate } from "../main/users/AddOrUpdate";

function App() {
  return (
    <Suspense fallback={<h1>Loading...</h1>}>
      <Routes>      
         <Route exact path="/users" element={<Users />} />     
         <Route path={`/users/add`} element={<AddOrUpdate />} />
         <Route path={`users/edit/:id`} element={<AddOrUpdate />} />     
       </Routes>   
    </Suspense>       
  );
}

export { App };
