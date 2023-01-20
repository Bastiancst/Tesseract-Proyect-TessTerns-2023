import { AppBar, Avatar, Box, Button, Container, Grid, Stack, Toolbar, Menu, MenuItem } from "@mui/material"
import React from "react"
import { Link } from 'react-router-dom';

import { useState } from 'react';
import { useAppDispatch, useAppSelector } from '../../redux/store';

export default function BasicMenu() {
    const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
    const open = Boolean(anchorEl);
    const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
      setAnchorEl(event.currentTarget);
    };
    const handleClose = () => {
      setAnchorEl(null);
    };
  
    return (
      <div>
        <Button
          id="basic-button"
          aria-controls={open ? 'basic-menu' : undefined}
          aria-haspopup="true"
          aria-expanded={open ? 'true' : undefined}
          onClick={handleClick}
          color='warning'
        >
            icon
        </Button>
        <Menu
          id="basic-menu"
          anchorEl={anchorEl}
          open={open}
          onClose={handleClose}
          MenuListProps={{
            'aria-labelledby': 'basic-button',
          }}
        >
            <Link to={'/'}>
                <MenuItem onClick={handleClose}>Inicio</MenuItem>
            </Link>
            <Link to={'/Login'}>
                <MenuItem onClick={handleClose}>Login</MenuItem>
            </Link>
            <Link to={'/Register'}>
                <MenuItem onClick={handleClose}>Register</MenuItem>
            </Link>
        </Menu>
      </div>
    );
  }

export const Navbar:React.FC<{}> = () => {

    const dispatch = useAppDispatch()
    const isLoggin = useAppSelector(state => state.login_act.isLoggin)

    return(
        <div>
            <Box sx={{flexGrow: 1}}>
                <AppBar position="fixed">
                    <Toolbar>
                        <Container maxWidth="xl"
                        sx={{display:{xs:'none',sm:'block'}}}>
                            <Grid container
                                direction="row"
                                justifyContent="space-between"
                                alignItems="center"
                                
                            >   
                                <Grid item>
                                    <Link to="/">
                                            <Button 
                                            startIcon={<Avatar src="https://www.zarla.com/images/zarla-construye-fcil-1x1-2400x2400-20220117-wgxpttwhr8bf9cpyk4hy.png?crop=1:1,smart&width=250&dpr=2" 
                                            variant="rounded"
                                            />
                                            } 
                                            variant="outlined"
                                            >Ferreteria
                                            </Button>
                                    </Link>
                                </Grid>
                                <Grid item>
                                    <Stack direction="row" spacing={2}>
                                        <Link to="/Login">
                                            {!isLoggin? <Button variant="contained">Login</Button> : false}
                                        </Link>
                                        <Link to="/Register">
                                            {!isLoggin? <Button variant="contained">Register</Button> : false}
                                        </Link>
                                    </Stack>
                                </Grid>
                            </Grid>
                        </Container>
                        <Grid container
                            sx={{display:{xs:'block',sm:'none'}}}>
                            <Grid item>
                                <BasicMenu />
                            </Grid> 
                        </Grid>        
                    </Toolbar>
                </AppBar>
            </Box>
            <div></div>
        </div>
    )   
}