import React from 'react'
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Logo from '../addons/logo.png'

import '../styles/catalogueStyle.css'

interface properties{
  title: string
  urlimg: string
  description: string
  price: number
}

export const CatalogueComponent = (props: properties) => {
  return (
    <Card sx={{ maxWidth: 345 }}
    id='main'>
      <CardMedia
        component="img"
        height="140"
        image={props.urlimg}
      />
      <CardContent>
        <Typography gutterBottom variant="h5" component="div" id='title'>
          {props.title}
        </Typography>
        <Typography variant="body2" color="text.secondary" id='description'>
          {props.description}
        </Typography>
        <Typography variant="body2" color="text.secondary" id='price'>
          Price:{props.price}
        </Typography>
      </CardContent>
      <CardActions>
        <Button size="small" id='buy-button'>Buy</Button>
      </CardActions>
    </Card>
  )
}