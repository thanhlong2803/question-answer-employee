import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import "../authentication/login.css"
import { yupResolver } from '@hookform/resolvers/yup';
import { useForm } from "react-hook-form";
import * as Yup from 'yup';

import { authenticationService } from '../_services/authentication/authentication.service'

const Login = () => {
    const navigate = useNavigate();

    const validationSchema = Yup.object().shape({
        username: Yup.string()
            .required('Tên đăng nhập không được để trống').nullable(),
        password: Yup.string()
            .required('Mật khẩu không được để trống').nullable()
    });

    const { register, handleSubmit, setValue, formState: { errors } } = useForm({
        resolver: yupResolver(validationSchema)
    });

    function login(data) {
        console.log(data);
        authenticationService.login(data);
    }

    useEffect(() => {
        const fields = ['username', 'password'];
        fields.forEach(field => setValue(field));
    })

    return (
        <div className="login-wrap">
            <div className="login-html">
                <input id="tab-1" type="radio" name="tab" className="sign-in" aria-checked /><label htmlFor="tab-1" className="tab">Sign In</label>
                <input id="tab-2" type="radio" name="tab" className="for-pwd" /><label htmlFor="tab-2" className="tab">Forgot Password</label>
                <form onSubmit={handleSubmit(login)} className="login-form">
                    <div className="sign-in-htm">
                        <div className="group">
                            <label htmlFor="username" className="label">Tên đăng nhập</label>
                            <input id="username" type="text" className="input" {...register('username', { required: true })} />
                            {errors.username && <p>{errors.username.message}</p>}
                            <div className="invalid-feedback"></div>
                        </div>
                        <div className="group">
                            <label htmlFor="password" className="label">Mật khẩu</label>
                            <input id="password" type="password" className="input" data-type="password" {...register('password', { required: true })} />
                            <div className="invalid-feedback"> {errors.password && <p>{errors.password.message}</p>}</div>

                        </div>
                        <div className="group">
                            <input type="submit" className="button" value="Sign In" />
                        </div>
                        <div className="hr"></div>
                    </div>
                    <div className="for-pwd-htm">
                        <div className="group">
                            <label htmlFor="user" className="label">Tên đăng nhập</label>
                            <input id="user" type="text" className="input" />
                        </div>
                        <div className="group">
                            <input type="submit" className="button" value="Reset Password" />
                        </div>
                        <div className="hr"></div>
                    </div>
                </form>
            </div>
        </div>
    );
};

export { Login };