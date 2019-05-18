import React, {Component} from 'react';
import './style.css';
import NavButton from "../NavButton";
import info from './src/home.svg'

class NavPanel extends Component{

    constructor(props){
        super(props);
        this.state = {
            activeIndex: 0
        }
    }

    render() {
        let navButtons = [];
        for(let i = 0; i < 5; i++){
            let className = (i === 0) ? 'col-2 offset-1' : 'col-2';
            navButtons[i] =
                <div key={i} className={className}>
                    <NavButton
                        isActive={this.state.activeIndex === i}
                        image={info}
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