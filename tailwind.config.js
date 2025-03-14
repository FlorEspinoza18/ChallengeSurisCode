module.exports = {
  content: ["./src/index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  purge: ["./index.html", "./src/**/*.{vue,js,ts,jsx,tsx}"],
  darkMode: "class", // or 'media' or 'class'
  theme: {
    extend: {
      maxWidth: {
        "1/4": "25%",
        "1/2": "50%",
        "3/4": "75%",
      },
      fontFamily: {
        sans: [
          "Inter",
          "system-ui",
          "-apple-system",
          "BlinkMacSystemFont",
          "Segoe UI",
          "Roboto",
          "Oxygen",
          "Ubuntu",
          "Cantarell",
          "Fira Sans",
          "Droid Sans",
          "Helvetica Neue",
          "sans-serif",
        ],
      },
      colors: {
        primary: {
          DEFAULT: "#00C48C", // Primary color
          50: "#F0FAF5",
          100: "#D9F4E1",
          200: "#B3ECCB",
          300: "#8BE4B5",
          400: "#65DCA0",
          500: "#00C48C", // Same as DEFAULT
          600: "#00B478",
          700: "#009E64",
          800: "#008A50",
          900: "#006C38",
        },
        secondary: {
          DEFAULT: "#34D7E8", // Secondary color
          50: "#F0FAFC",
          100: "#D9F2F6",
          200: "#B3E0EC",
          300: "#8BCEE2",
          400: "#65BCD8",
          500: "#34D7E8", // Same as DEFAULT
          600: "#00C1D1",
          700: "#00ADBB",
          800: "#0097A4",
          900: "#007D88",
        },
      },
    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
