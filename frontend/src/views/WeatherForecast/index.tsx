import DataWrapper from '../../components/DataWrapper';
import WeatherCard from '../../components/WeatherCard';
import useWeatherData from '../../hooks/useWeatherData';
import { StyledButton, StyledInput, WeatherCards, WeatherForecastContainer } from './styles';

function WeatherForecast() {
  const { address, setAddress, weatherData, error, loading, fetchWeatherData } = useWeatherData();

  const handleSubmit = (event: React.FormEvent) => {
    event.preventDefault();
    fetchWeatherData(address);
  };

  return (
    <WeatherForecastContainer>
      <form onSubmit={handleSubmit}>
        <StyledInput
          type="text"
          value={address}
          onChange={(e) => setAddress(e.target.value)}
          placeholder="Enter address"
        />
        <StyledButton type="submit">Get Forecast</StyledButton>
      </form>

      <DataWrapper loading={loading} error={error}>
        <WeatherCards>
          {weatherData.length > 0 &&
            weatherData.map((dayData, index) => <WeatherCard key={index} data={dayData} />)}
        </WeatherCards>
      </DataWrapper>
    </WeatherForecastContainer>
  );
}

export default WeatherForecast;
