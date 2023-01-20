import { Box, Button, Container, Grid, Stack, Toolbar } from "@mui/material"
import React from "react"
import { Link } from 'react-router-dom';
import { useAppDispatch, useAppSelector } from "../../redux/store";

export const Footer: React.FC<{}> = () => {
    const linkList = [
        {
            path: '/Login',
            name: 'Login'
        }, {
            path: '/Register',
            name: 'Register'
        }, {
            path: '/',
            name: 'Inicio'
        }, {
            path: '/',
            name: 'Catalogo'
        }
    ]

    const dispatch = useAppDispatch()
    const isLoggin = useAppSelector(state => state.login_act.isLoggin)

    return (
        <Box sx={{ flexGrow: 1 }}>
            <Toolbar>
                <Container maxWidth="xl" >
                    <Grid container
                        sx={{
                            bottom: 0,
                            xs: 2,
                        }}
                    >
                        <Stack direction="row" >
                            {
                                linkList.map((element, index) => {
                                    if (isLoggin && index != 2 && index != 3) {
                                        return false
                                    }
                                    return (
                                        <Link to={element.path} key={index}>
                                            <Button variant="text">{element.name}</Button>
                                        </Link>
                                    )
                                })
                            }
                        </Stack>
                    </Grid>
                </Container>
            </Toolbar>
        </Box>
    )
}