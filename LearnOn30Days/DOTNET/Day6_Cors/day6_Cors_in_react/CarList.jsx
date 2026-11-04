import React, { useEffect, useState } from 'react';
export default function CarList() {
    const [cars, setCars] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [errorMessage, setErrorMessage] = useState('');
    useEffect(() => {
        const fetchCars = async () => {
            try {
                setIsLoading(true);
                setErrorMessage('');

                // Gọi API Backend .NET Core
                const response = await fetch('https://localhost:7159/api/carday4/car05');

                if (!response.ok) {
                    throw new Error(`Lỗi kết nối máy chủ (Mã: ${response.status})`);
                }

                const result = await response.json();
                console.log(response)
                // Giả sử API trả về định dạng wrapper ApiResponse { data: [...] }
                setCars(result.data || []);
            } catch (err) {
                setErrorMessage(err.message || 'Không thể tải danh sách xe.');
            } finally {
                setIsLoading(false);
            }
        };

        fetchCars();
    }, []);

    if (isLoading) return <div>Đang tải dữ liệu...</div>;
    if (errorMessage) return <div style={{ color: 'red' }}>Lỗi: {errorMessage}</div>;

    return (
        <div>
            <h2>Danh Sách Xe</h2>
            <ul>
                {cars.map((car) => (
                    <li key={car.carID}>
                        <strong>{car.carName}</strong> - {car.carType} (${car.carPrice})
                    </li>
                ))}
            </ul>
        </div>
    );
}