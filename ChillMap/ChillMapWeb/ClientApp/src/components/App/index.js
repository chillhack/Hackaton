import React, { Component } from 'react';
import MainScreen from "../MainScreen";

export default class App extends Component {
    static displayName = App.name;

    render () {
        return (
                <div className='container-fluid'>
                    <MainScreen />
                </div>
        );
    }
}