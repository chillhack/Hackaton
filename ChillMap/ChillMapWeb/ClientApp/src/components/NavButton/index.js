import React from 'react';
import './style.css'

export default function NavButton({isActive, onClick}) {

    const imgSrc = isActive ? '' : '';
    return(
        <div >
            <div className='nav-btn'>
                <button
                    onClick={onClick}
                    className='btn'
                    style={{backgroundImage: {imgSrc}}}
                />
            </div>
        </div>
    );
}