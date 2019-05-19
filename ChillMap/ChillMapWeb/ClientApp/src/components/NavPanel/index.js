import React, {Component} from 'react';
import './style.css';
import NavButton from "../NavButton";
import home from './src/home.svg'
import loc from './src/loc.svg'
import serch from './src/serch.svg'
import man from './src/man.svg'

class NavPanel extends Component{

    constructor(props){
        super(props);
        this.pic = [home, man,  serch, loc];
        this.state = {
            activeIndex: 0
        }
    }

    render() {
        let navButtons = [];
        for(let i = 0; i < 4; i++){
            let className = (i === 0) ? 'col-2 offset-2' : 'col-2';
            navButtons[i] =
                <div key={i} className={className}>
                    <NavButton
                        isActive={this.state.activeIndex === i}
                        image={this.pic[i]}
                        onClick={() => this.onClick(i)}
                    />
                </div>
        }

        return (
            <div className='row'>
                {navButtons}
            </div>
        );

    }

    onClick = (index) => {
        this.setState(
            {
                activeIndex: index
            });
        this.props.clickHandler(index);
    }
}

export default NavPanel;