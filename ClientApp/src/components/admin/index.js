import React from 'react';
import { connect } from 'react-redux';
import './styled.css';

const Admin = props => {
    const login = () => {
        console.log("enter");
    }
    return (
        <div className="login">
            <button className="btnLogin btn btn-primary" onClick={login}>
                Войти
       </button>
        </div>
    );
};

export default connect()(Admin);
