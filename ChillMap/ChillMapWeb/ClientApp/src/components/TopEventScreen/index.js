import React, {Component} from 'react';
import SearchLine from "../SearchLine";
import events from './events';
import EventCardBox from "../EventCardBox";
import './style.css'

class TopEventScreen extends Component{
    render() {
        return(
            <div className={'top-screen'}>
                <EventCardBox events={events} />
            </div>
        );
    }
}

export default TopEventScreen;
