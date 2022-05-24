import React from "react";
import {  Routes,  Route,  Router} from "react-router-dom";
// import { Nav, Alert } from '@/_components';
// import { Home } from '@/home';

import {Users} from "../main/users/Index"
import {List} from "../main/users/List"

function App() {
  return (
    <Routes>      
        <Route exact path="/users" component={Users} />
    </Routes>    
  );
}

export { App };
