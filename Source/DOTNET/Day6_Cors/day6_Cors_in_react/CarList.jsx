import React, { useEffect, useState } from 'react';
export default function CarList() {
    const [carInfo, setCarInfo] = useState({});
    const [isLoading, setIsLoading] = useState(true);
    const [errorMessage, setErrorMessage] = useState('');
    const [errorCode, setErrorCode] = useState('');
    const [statusCode, setStatusCode] = useState('');
    useEffect(() => {
        const fetchCars = async () => {
            try {
                setIsLoading(true);
                setErrorMessage('');

                // Gọi API Backend .NET Core
                const response = await fetch('https://localhost:7224/api/carday4/car05');
                console.log(response)
                if (!response.ok) {
                    throw new Error(`Lỗi kết nối máy chủ (Mã: ${response.status})`);
                }

                const result = await response.json();
                
                // 3. Kiểm tra logic nghiệp vụ từ ApiResponse
                if (result.success) {
                    setCarInfo(result.data); // Đổ dữ liệu xe vào state
                } else {
                    setErrorMessage(result.messageDetail || 'Không thể lấy dữ liệu.');
                    setErrorCode(result.errorCode || 'Không thể lấy dữ liệu.');
                    setStatusCode(result.statusCode || 'Không thể lấy dữ liệu.');
                }

                
            } catch (err) {
                setErrorMessage(err.message || 'Không thể tải danh sách xe.');
            } finally {
                setIsLoading(false);
            }
        };

        fetchCars();
    }, []);

    if (isLoading) return <div>Đang tải dữ liệu...</div>;
    if (errorMessage) return <div style={{ color: 'red' }}>Lỗi: {errorMessage}, Mã Lỗi: {errorCode}, Error Code Number: {statusCode}</div>;

    return (
        <div>
           <h2>Thông tin xe</h2>
           <div style={{ padding: '16px', border: '1px solid #ccc', borderRadius: '8px' }}>
            <h2>Thông tin xe</h2>
            <p><strong>Mã xe:</strong> {carInfo.carID}</p>
            <p><strong>Tên xe:</strong> {carInfo.carName}</p>
            <p><strong>Dòng xe:</strong> {carInfo.carType}</p>
            <p><strong>Giá xe:</strong> ${carInfo.carPrice}</p>
            <p><strong>Tốc độ tối đa:</strong> {carInfo.carTopSpeed} km/h</p>
        </div>
        </div>
    );
}