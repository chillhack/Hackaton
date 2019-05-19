import React, {Component} from 'react';
import SearchLine from "../SearchLine";
import events from './events';
import EventCardBox from "../EventCardBox";
import './style.css'
import axios from 'axios'

class TopEventScreen extends Component {
    constructor(props) {
        super(props)
        this.state = {data: []}
    }

    componentWillMount() {
        axios.get('./api/events')
            .then(resp => this.setState({data: resp.data}))
    }

    render() {
        return (
            <div className={'top-screen'}>
                <EventCardBox events={this.state.data}/>
            </div>
        );
    }
}

export default TopEventScreen;
