import React from 'react';
import { Route, Routes, useLocation } from 'react-router-dom';

import { List } from './List';

function Users({ match }) {   
    const { pathname } = useLocation();    
    return (
        <Routes>
           <Route path={pathname} component={List} />    
        </Routes>
    );
}

export { Users };