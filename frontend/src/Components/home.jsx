import { useState, useEffect } from "react";
import BasePage from "./BasePage";
import MenuTabs from "./menu";
import { useNavigate } from "react-router-dom";

// Componente principal de la página de inicio
function Home() {
  const navigate = useNavigate();
  
  return (
    <BasePage>
      <div className="container mx-auto p-4">
        <div className="mt-8 text-center">
          <h2 className="text-3xl font-bold">Bienvenido a la Página de Reservas</h2>
          <p className="mt-4 text-lg">Realiza tu reserva de manera rápida y fácil.</p>
          <MenuTabs />
        </div>
      </div>
    </BasePage>
  );
}

export default Home;
