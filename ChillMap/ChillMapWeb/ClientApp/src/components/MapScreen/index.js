import React from 'react';
import 'bootstrap/dist/css/bootstrap.css';
import './style.css'
import AnimatedText from "../AnimatedText";

export default function MapScreen() {
    return (
        <div className='start-screen'>
            <div className='row' style={{height: '70px'}}>
                <div className='col-2'>
                    <div className='logo'>

                    </div>
                </div>
                <div className='col-2 offset-8'>
                    <div className='login'>

                    </div>
                </div>
            </div>
            <div className='row' style={{height: '130px'}}>
                <div className='col-4'>
                    <AnimatedText text={'ChillMap'}/>
                </div>
            </div>
            <div className='row'>
                <div className='col col-lg-6'>
                    <div className='text-muted'>
                    </div>
                </div>
            </div>
        </div>
    );
}