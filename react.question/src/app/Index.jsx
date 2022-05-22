import React from 'react';
import { Router,Routes,Route, Switch, Redirect, useLocation } from 'react-router-dom';

// import { Nav, Alert } from '@/_components';
// import { Home } from '@/home';
import { users } from '../main/users';

function App() {
    const { pathname } = useLocation();  
    return (
        <div className="app-container bg-light">
            {/* <Nav />
            <Alert /> */}
            <div className="container pt-4 pb-4">
                {/* <Switch>
                    <Redirect from="/:url*(/+)" to={pathname.slice(0, -1)} />                    
                    <Routes path="/users" component={users} />
                    <Redirect from="*" to="/" />
                </Switch> */}
                 <Router>
                    <Routes>
                        <Route path='/' element={<users/>}/>
                    </Routes>
                 </Router>
            </div>
        </div>
    );
}

export { App };