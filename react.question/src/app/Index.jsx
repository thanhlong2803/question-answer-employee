

import React, { Suspense } from "react";
import { Routes, Route } from "react-router-dom";


// import { Nav, Alert } from '@/_components';
// import { Home } from '@/home';

import { Users } from "../main/users/Index";
import { AddOrUpdate } from "../main/users/AddOrUpdate";
import { Login } from "../authentication/Login"

function App() {
  return (
    <Suspense fallback={<h1>Loading...</h1>}>
      <Routes>        
        <Route exact path="" element={<Login />} />

        <Route path="/users" element={<Users />} caseSensitive=""/>
        <Route path={`/users/add`} element={<AddOrUpdate />} />
        <Route path={`users/edit/:id`} element={<AddOrUpdate />} />
      </Routes>
    </Suspense>
  );
}

export { App };
