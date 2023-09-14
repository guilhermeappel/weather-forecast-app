export interface IMeasurement {
  unitCode?: string;
  value?: number;
}

export interface IPeriod {
  number?: number;
  name?: string;
  startTime?: Date;
  endTime?: Date;
  isDaytime?: boolean;
  temperature?: number;
  temperatureUnit?: string;
  temperatureTrend?: IMeasurement;
  probabilityOfPrecipitation?: IMeasurement;
  dewpoint?: IMeasurement;
  relativeHumidity?: IMeasurement;
  windSpeed?: string;
  windDirection?: string;
  icon?: string;
  shortForecast?: string;
  detailedForecast?: string;
}
