import { IPeriod } from '../types/weather-types';
import axios from './axios';

export const fetchWeatherForecast = async (address: string): Promise<IPeriod[] | undefined> => {
  try {
    const response = await axios.get<IPeriod[]>('/weatherforecast', {
      params: {
        address,
      },
    });
    return response.data;
  } catch (error) {
    throw error;
  }
};
