import React from 'react';
import EventCard from "../EventCard";
import './style.css';

export default function EventCardBox({events}) {
    let items = events.map(e =>
        <li key={e.id} style={{margin: '15px'}}><EventCard event={e}/></li>
    );
    return(
        <ul className={"list"}>
            {items}
        </ul>
    );

}