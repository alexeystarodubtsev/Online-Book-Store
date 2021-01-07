import React, { Fragment } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import Admin from './components/admin';
import FetchData from './components/FetchData';

export default () => (
    <Fragment>
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/admin' component={Admin} />
    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
    </Fragment>
);
