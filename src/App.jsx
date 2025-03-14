import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './index.css'
import './App.css'
import Consulta from "./Components/consultarServicios"; // Importa la nueva vista
import Home from './Components/home'
import { Routes, Route } from "react-router-dom"; // Agregar esta importación

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
      <Routes>
      <Route path="/consultarServicios" element={<Consulta />} />
        <Route path="/" element={<Home />} />
      </Routes>
      </div>
    </>
  )
}

export default App
