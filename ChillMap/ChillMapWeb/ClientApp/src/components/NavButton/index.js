import React from 'react';
import './style.css'

export default function NavButton({isActive, image, onClick}) {

    return(
        <div >
            <div className='nav-btn'>
                <button onClick={onClick} className='btn'><img className={'img'} src={image}/></button>
            </div>
        </div>
    );
}