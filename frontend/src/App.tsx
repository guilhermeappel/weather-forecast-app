import WeatherForecast from './views/WeatherForecast';

const containerStyle: React.CSSProperties = {
  display: 'flex',
  flexDirection: 'column',
  justifyContent: 'center',
  alignItems: 'center',
  height: '100vh',
  backgroundColor: '#1a1a1a',
  color: '#e0e0e0',
};

function App() {
  return (
    <div style={containerStyle}>
      <h1>Weather Forecast</h1>
      <WeatherForecast />
    </div>
  );
}

export default App;
