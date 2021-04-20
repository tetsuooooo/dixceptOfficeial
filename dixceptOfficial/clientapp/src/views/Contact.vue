<template>
    <div>
        <v-row>
            <v-col cols="12">
                <v-img :src="require('../assets/NoImg.png')" width="100%" height="40vh"></v-img>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="10">
                <v-card>
                    <validation-observer ref="observer" v-slot="{invalid}">
                        <v-form @submit.prevent="submit">
                            <v-row justify="center">
                                <v-col cols="10" class="mt-5">
                                    <v-row justify="center">
                                        <v-col cols="12" class="text-h4 text-center">お問合せ</v-col>
                                    </v-row>
                                    <v-row justify="center">
                                        <v-col cols="6">
                                            <validation-provider v-slot="{errors}" name="名前" rules="required|max:30">
                                                <v-text-field v-model="name" :counter="nameMax" :error-messages="errors" label="お名前" placeholder="お名前" required></v-text-field>
                                            </validation-provider>
                                        </v-col>
                                    </v-row>
                                    <v-row justify="center">
                                        <v-col cols="6">
                                            <v-text-field v-model="teamName" :counter="teamNameMax" label="チーム名" placeholder="チーム名"></v-text-field>
                                        </v-col>
                                    </v-row>
                                    <v-row justify="center">
                                        <v-col cols="6">
                                            <validation-provider v-slot="{errors}" name="メールアドレス" rules="required|email">
                                                <v-text-field v-model="mailAddress" :error-messages="errors" label="メールアドレス" placeholder="メールアドレス" required></v-text-field>
                                            </validation-provider>
                                        </v-col>
                                    </v-row>
                                    <v-row justify="center">
                                        <v-col cols="6">
                                            <validation-provider v-slot="{errors}" name="お問い合わせ内容" rules="required">
                                                <v-textarea v-model="content" :error-messages="errors" required>
                                                    <template v-slot:label>
                                                        <div>
                                                            お問合せ内容
                                                        </div>
                                                    </template>
                                                </v-textarea>
                                            </validation-provider>
                                        </v-col>
                                    </v-row>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="10" class="text-center">
                                    <v-btn type="submit" :disabled="invalid">送信</v-btn>
                                </v-col>
                            </v-row>
                        </v-form>
                    </validation-observer>
                </v-card>
            </v-col>
        </v-row>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import { ValidationProvider, ValidationObserver, extend, setInteractionMode } from 'vee-validate';
    import { required, email, regex, max } from 'vee-validate/dist/rules';

    // TODO: validation別ファイルに切り出す
    setInteractionMode('eager')
    extend('required', {
        ...required,
        message: '{_field_}は必須項目です。'
    })
    extend('max', {
        ...max,
        message: '{_field_}は{length}文字以内で入力してください。'
    })
    extend('email', {
        ...email,
        message: 'メールアドレスは正しい形式で入力してください。',
    })
    extend('regex', {
        ...regex,
        message: '{_field_} {_value_} does not match {regex}',
    })

    @Component({
        components: {
            ValidationProvider,
            ValidationObserver
        },
    })
    export default class Contact extends Vue {
        data() {
            const nameMax = 30
            const teamNameMax = 100
            return {
                mailAddress: '',
                teamName: '',
                name: '',
                nameMax,
                teamNameMax,
                content: '',
            }
        }

        submit() {
            this.$refs.observer.validate();
        }
    }
</script>

<style scoped>
    .border_left {
        border-left: solid 5px green;
    }
</style>
