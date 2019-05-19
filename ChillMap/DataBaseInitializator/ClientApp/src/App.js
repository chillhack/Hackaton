import React, {Component} from 'react';
import {Route, Switch} from 'react-router-dom'
import {VkApi} from "./components/Vk";
import {VkCallback} from "./components/VkCallback";

export default class App extends Component {
    constructor(props){
        super(props);
        this.state = {};
        // this.getAllFutureEvents.bind(this)


    }
    static displayName = App.name;

    render() {
        return (
            <Switch>
                <Route exact path="/" component={VkApi}/>
                <Route path="/callback" component={VkCallback}/>
            </Switch>
        );
    }
}
