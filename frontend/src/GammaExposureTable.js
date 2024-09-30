import React, { useState, useEffect } from "react";
import axios from "axios";

const GammaExposureTable = () => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(
          "http://localhost:5012/api/gammaexposure"
        );
        setData(response.data);
        setLoading(false);
      } catch (err) {
        setError("Error fetching data");
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  if (loading) return <div>Loading...</div>;
  if (error) return <div>{error}</div>;

  return (
    <div>
      <h2>Gamma Exposure Data</h2>
      <table>
        <thead>
          <tr>
            <th>Symbol</th>
            <th>Date</th>
            <th>Gamma Exposure</th>
            <th>Price</th>
          </tr>
        </thead>
        <tbody>
          {data.map((item, index) => (
            <tr key={index}>
              <td>{item.symbol}</td>
              <td>{new Date(item.date).toLocaleDateString()}</td>
              <td>{item.gammaExposure}</td>
              <td>{item.price}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default GammaExposureTable;
