import React, { useEffect, useState } from 'react'
import Carousel from '../../components/hero/Hero'
import { images } from '../../common/zeldas'
import { CatalogueComponent } from '../../components/CatalogueComponent'
import axios from 'axios'

export const Home: React.FC<{}> = () => {

  const [elements, setElement] = useState("")
  const URL = "https://localhost:7072/api/ItemAPI"

  async function returnData() {
    axios.get(URL).then((res) => {
      console.log(res);
      setElement(res.data.result)
      
    })
  }

  console.log(returnData())

  return (
    <div>
      <Carousel images={images} autoPlay={true} showButtons={true} />
    </div>
  )
}
