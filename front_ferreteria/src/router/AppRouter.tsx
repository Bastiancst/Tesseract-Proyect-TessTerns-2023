import { Box } from '@mui/material';
import React from 'react';
import { Route, Routes, Navigate } from 'react-router-dom';
import { Navbar } from '../components/navbar/Navbar';
import { Home } from '../pages/public/Home';
import { Login } from '../pages/public/Login';
import { Footer } from '../components/footer/Footer';
import { Register } from '../pages/public/Register';
import "../components/footer/a.css"

export const AppRouter: React.FC<{}> = () => {

    return (
        <div>
            <Navbar />
            <Box pt={10}>
                <Routes>
                    <Route path='/' element={<Home />} />
                    <Route path='/login' element={<Login />} />
                    <Route path='/register' element={<Register />} />
                    <Route path='/adminPanel' />
                    <Route path='*' element={<Navigate to="/"/>}/>
                </Routes>
                <div className='afo'>
                <Footer/>
                </div>
            </Box>
        </div>
    );
};
