const requestBooks = 'REQUEST_BOOKS';
const receiveBooks = 'RECEIVE_BOOKS';
const SetAdminStatus = 'SET_ADMIN_STATUS';
const initialState = { bookList: [], isLoading: false, adminLoggedIn: false };

export const actionCreators = {
    requestBooks: () => async (dispatch, getState) => {
        dispatch({ type: requestBooks });

        const url = `api/book`;
        const response = await fetch(url);
        const books = await response.json();
        dispatch({ type: receiveBooks, payload: { books } });
        console.log(books);
        
    },
    setLogIn: () => async (dispatch) => {
        const loggedIn = localStorage.getItem('logIn');

        const newStatus = loggedIn === 'logged' ? 'InLogged' : 'logged';
        localStorage.setItem('logIn', newStatus);
        dispatch({ type: SetAdminStatus, payload: { loggedIn: newStatus === 'logged' } });

    },

    getLogIn: () => async (dispatch) => {

        const loggedIn = localStorage.getItem('logIn');
        dispatch({ type: SetAdminStatus, payload: { loggedIn: loggedIn === 'logged' } });

    }

};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestBooks) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveBooks) {
        return {
            ...state,
            bookList: action.payload.books,
            isLoading: false
        };
    }

    if (action.type === SetAdminStatus) {
        return {
            ...state,
            adminLoggedIn: action.payload.loggedIn
        };
    }
    return state;
};
