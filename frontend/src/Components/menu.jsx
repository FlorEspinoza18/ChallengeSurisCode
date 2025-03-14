import React from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";


const tabs = [
  { name: "Consultar", path: "/consultarServicios" }
];

function MenuTabs() {
  const navigate = useNavigate();

  const obtenerReservas = async () => {
    try {
      // url a modo de prueba, caso contrario de vincular con backend si se estuviera utilizando base de datos, se utilizaría : "api/gestion-reservas/servicios-obtener"
      const response = await axios.get("http://localhost:5000/servicios"); 
      console.log(response.data)
      return response.data; 
    } catch (error) {
      console.error("Error al obtener reservas:", error);
    }
  };

  const handleNavigation = async (path) => {
    try {
      // url a modo de prueba, caso contrario de vincular con backend si se estuviera utilizando base de datos, se utilizaría : "api/gestion-reserva/reservas-obtener" 
      const response = await obtenerReservas(); 
      navigate(path, { state: { reservas: response } });  
    } catch (error) {
      console.error("No se pudieron obtener las reservas:", error);
    }
  };
  
  return (
    <div className="border-b border-gray-600">
      <div className="flex justify-center space-x-8">
        {tabs.map((tab) => (
          <button
            key={tab.name}
            onClick={() => handleNavigation(tab.path)} 
            className="px-8 py-3 bg-blue-500 text-white rounded-md hover:bg-blue-600 transition"
          >
            {tab.name}
          </button>
        ))}
      </div>
    </div>
  );
}

export default MenuTabs;