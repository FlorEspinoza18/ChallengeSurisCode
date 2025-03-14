import React, { useState } from "react";
import { useLocation } from "react-router-dom"; 
import axios from "axios";

function Consulta() {
  const location = useLocation(); 
  const reservas = location.state?.reservas || []; 

  // Datos de fechas y horarios disponibles
  const initialDates = [
    { date: "2025-03-15", times: ["10:00", "10:30", "11:00", "12:00", "14:00", "16:00"] },
    { date: "2025-03-16", times: ["09:00", "09:30", "10:00", "11:00", "13:00"] },
    { date: "2025-03-17", times: ["08:00", "08:30", "09:00", "12:00", "15:00"] },
  ];
  const [availableDatesState, setAvailableDatesState] = useState(initialDates);

  const [modalOpen, setModalOpen] = useState(false);
  const [selectedService, setSelectedService] = useState(null);
  const [selectedDate, setSelectedDate] = useState("");
  const [selectedTime, setSelectedTime] = useState("");
  const [cliente, setCliente] = useState(""); 
  const [loading, setLoading] = useState(false);

  const handleReservarClick = (servicio) => {
    setModalOpen(true);
    setSelectedService(servicio);
  };

  const closeModal = () => {
    setModalOpen(false);
    setSelectedService(null);
    setSelectedDate("");
    setSelectedTime("");
    setCliente("");
  };

  const handleConfirmarReserva = async () => {
    // Validar que la reserva no le falten datos a completar
    if (!selectedService || !selectedDate || !selectedTime || !cliente) return;

    // Validación de fecha y hora esté disponible
    const dateObj = availableDatesState.find((d) => d.date === selectedDate);
    if (!dateObj || !dateObj.times.includes(selectedTime)) {
      alert("La combinación de fecha y hora ya está reservada.");
      return;
    }

    const reserva = {
      servicioId: selectedService.id,
      fecha: selectedDate,
      hora: selectedTime,
      cliente: cliente, 
    };

    try {
      setLoading(true);
      // url a modo de prueba, caso contrario de vincular con backend si se estuviera utilizando base de datos, se utilizaría : "api/gestion-reserva/crear-reserva" 
      const response = await axios.post(
        "http://localhost:5000/reservas",
        reserva,
        { headers: { "Content-Type": "application/json" } }
      );

      if (response.status === 200 || response.status === 201) {
        alert("Reserva confirmada con éxito!");

        setAvailableDatesState((prevDates) =>
          prevDates.map((dateObj) => {
            if (dateObj.date === selectedDate) {
              return {
                ...dateObj,
                times: dateObj.times.filter((time) => time !== selectedTime),
              };
            }
            return dateObj;
          })
        );

        closeModal();
      }
    } catch (error) {
      console.error("Error al confirmar la reserva:", error);
      alert("Hubo un problema al confirmar la reserva.");
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="p-6">
      <h1 className="text-2xl font-bold mb-4">Consultar Servicios</h1>
      <div className="space-y-4">
        {reservas.map((reserva) => (
          <div key={reserva.id} className="border p-4 rounded-lg shadow-md">
            <h2 className="text-xl font-semibold mb-2">{reserva.nombre}</h2>
            <p className="mb-4">{reserva.descripcion}</p>
            <button
              onClick={() => handleReservarClick(reserva)}
              className="bg-blue-500 text-white py-2 px-4 rounded"
            >
              Reservar
            </button>
          </div>
        ))}
      </div>

      {modalOpen && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
          <div className="bg-white p-6 rounded-lg w-[400px] max-w-full shadow-lg relative">
            <h2 className="text-xl font-semibold mb-4">
              Reservar: {selectedService?.nombre}
            </h2>
            <p className="mb-4">{selectedService?.descripcion}</p>

            <label className="block mb-2 font-semibold">Selecciona una fecha:</label>
            <div className="grid grid-cols-3 gap-2 mb-4">
              {availableDatesState.map((date) => (
                <button
                  key={date.date}
                  className={`border p-2 rounded-lg text-center ${
                    selectedDate === date.date ? "bg-blue-500 text-white" : "bg-gray-100"
                  }`}
                  onClick={() => {
                    setSelectedDate(date.date);
                    setSelectedTime("");
                  }}
                >
                  {date.date}
                </button>
              ))}
            </div>

            {selectedDate && (
              <>
                <label className="block mb-2 font-semibold">
                  Selecciona un horario:
                </label>
                <div className="grid grid-cols-3 gap-2 mb-4">
                  {availableDatesState
                    .find((d) => d.date === selectedDate)
                    ?.times.map((time) => (
                      <button
                        key={time}
                        className={`border p-2 rounded-lg text-center ${
                          selectedTime === time
                            ? "bg-green-500 text-white"
                            : "bg-gray-100"
                        }`}
                        onClick={() => setSelectedTime(time)}
                      >
                        {time}
                      </button>
                    ))}
                </div>
              </>
            )}

            <label className="block mb-2 font-semibold">Ingresa tu nombre:</label>
            <input
              type="text"
              value={cliente}
              onChange={(e) => setCliente(e.target.value)}
              placeholder="Ingrese su nombre"
              className="border p-2 rounded w-full mb-4"
            />

            <div className="flex justify-end space-x-2">
              <button
                onClick={closeModal}
                className="bg-gray-400 text-white py-2 px-4 rounded"
              >
                Cancelar
              </button>
              <button
                onClick={handleConfirmarReserva}
                disabled={!selectedDate || !selectedTime || loading || !cliente}
                className={`py-2 px-4 rounded text-white ${
                  !selectedDate || !selectedTime || loading || !cliente
                    ? "bg-gray-300 cursor-not-allowed"
                    : "bg-green-500"
                }`}
              >
                {loading ? "Enviando..." : "Confirmar Reserva"}
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}

export default Consulta;