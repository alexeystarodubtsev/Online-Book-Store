const requestBooks = 'REQUEST_BOOKS';
const receiveWeatherForecastsType = 'RECEIVE_WEATHER_FORECASTS';
const initialState = { bookList: [], isLoading: false, adminLoggedIn: false };

export const actionCreators = {
    requestBooks: () => async (dispatch, getState) => {
        // dispatch({ type: requestWeatherForecastsType, startDateIndex });

        const url = `api/book`;
        const response = await fetch(url);
        const books = await response.json();
        console.log(books);
        
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestWeatherForecastsType) {
        return {
            ...state,
            startDateIndex: action.startDateIndex,
            isLoading: true
        };
    }

    if (action.type === receiveWeatherForecastsType) {
        return {
            ...state,
            startDateIndex: action.startDateIndex,
            forecasts: action.forecasts,
            isLoading: false
        };
    }

    return state;
};
