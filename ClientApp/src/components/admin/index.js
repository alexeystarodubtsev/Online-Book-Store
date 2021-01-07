import React, { useEffect } from "react";
import { connect } from 'react-redux';
import './styled.css';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../../store/books';

const Admin = ({ adminLoggedIn, getLogIn, setLogIn }) => {

    useEffect(() => {
        getLogIn();
    }, []);

    const login = () => {
        setLogIn();
    }

    return (
        <div className="login">
            {adminLoggedIn ?
                <button className="btnLogin btn btn-primary" onClick={login}>
                    Выйти
                </button> :
                <button className="btnLogin btn btn-primary" onClick={login}>
                    Войти
                </button>
            }
        </div>
    );
};

export default connect(
    state => state.books,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Admin);
