import React from 'react';
import './style.css';

class AnimatedText extends React.Component{

    constructor(props){
        super(props);
        this.state = {
            animatedClass: ''
        };
    }

    componentDidMount() {
        setTimeout(() => this.setState(
            {animatedClass: 'animated'}
        ), 0);
    }

    render() {
        return(
            <div className={this.state.animatedClass}>
            <div className='header'>
                <h1 className='display-1'>{this.props.text}</h1>
            </div>
        </div>);
    };
}

export default AnimatedText;