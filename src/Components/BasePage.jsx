import React from "react";
export default function BasePage({ children }) {
  return (
    <div className="w-full min-h-screen bg-gray-900 text-white">{children}</div>
  );
}
