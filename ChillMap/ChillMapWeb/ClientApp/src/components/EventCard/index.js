import React, {Component} from 'react';
import './style.css'
import 'bootstrap/dist/css/bootstrap.css';

export default class EventCard extends Component{
    constructor(props){
        super(props);
        this.state = {
            isOpen: false
        }
    }

    render() {
        let desc = this.state.isOpen && <p className='card-text'>{this.props.event.description}</p>;
        console.log(this.props.events);
        return (
            <div className='col-lg-8 offset-2'>
            <div className={'card'}>
                <div className='card-body'>
                    <img src={''} className='card-img-top'/>
                    <p><h5 className={'card-title'}>{this.props.event.name}</h5>
                        <button className={'btn-more'} onClick={this.clickHandler}>More</button></p>
                    <p className='card-subtitle mb-2 text-muted'>{this.props.event.date}</p>
                    {desc}
                </div>
            </div>
        </div>
        );
    }

    clickHandler = () => {
        console.log("!");
        this.setState(
            {
                isOpen: !this.state.isOpen
            }
        )
    }
}