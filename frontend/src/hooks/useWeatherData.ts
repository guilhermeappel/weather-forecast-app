import { useState } from 'react';
import { fetchWeatherForecast } from './../api/weather-api';
import { IPeriod } from './../types/weather-types';

const useWeatherData = () => {
  const [address, setAddress] = useState('');
  const [weatherData, setWeatherData] = useState<IPeriod[]>([]);
  const [error, setError] = useState<Error | null>(null);
  const [loading, setLoading] = useState<boolean>(false);

  const fetchWeatherData = async (address: string) => {
    setLoading(true);
    setError(null);
    try {
      const result = await fetchWeatherForecast(address);
      setWeatherData(result || []);
    } catch (err) {
      setError(err as Error);
    } finally {
      setLoading(false);
    }
  };

  return { address, setAddress, weatherData, error, loading, fetchWeatherData };
};

export default useWeatherData;
